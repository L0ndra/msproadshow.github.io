using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using msproadshow.Models;
using Newtonsoft.Json;

namespace msproadshow.DAL
{
    public class ParticipantDal{
        CloudStorageAccount _storageAccount; 
        public ParticipantDal(IConfiguration config){

            _storageAccount = new CloudStorageAccount(
                new Microsoft.WindowsAzure.Storage.Auth.StorageCredentials(
                    config["AzureStorage:StorageAccountName"],
                    config["AzureStorage:AccessKey"]), true);

        }

        public async Task AddNewParticipantAsync(ParticipantModel participant){
            CloudBlobClient _blobClient = _storageAccount.CreateCloudBlobClient();

            CloudBlobContainer container = _blobClient.GetContainerReference(participant.City);

            await container.CreateIfNotExistsAsync();

            var blob = container.GetBlockBlobReference(WebUtility.UrlEncode(participant.Email));

            await blob.UploadTextAsync(JsonConvert.SerializeObject(participant));
        }
    }
}
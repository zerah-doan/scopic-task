using Newtonsoft.Json;
using RestSharp;
using System.Net;

namespace ScopicTask.Test
{
    public class Task2ReqresTest
    {

        [Test]
        public async Task CrudUser()
        {
            var options = new RestClientOptions("https://reqres.in");
            var client = new RestClient(options);

            //1. Create user
            var reqCreate = new RestRequest("/api/users", Method.Post);
            var ogInfo = new { name = "Quang", job = "QA" };
            reqCreate.AddJsonBody(ogInfo);
            var resCreate = await client.PostAsync(reqCreate);
            Assert.That(resCreate.StatusCode, Is.EqualTo(HttpStatusCode.Created));
            string userId = JsonConvert.DeserializeObject<dynamic>(resCreate.Content).id;          

            //2. Update user
            var reqUpdate = new RestRequest($"/api/users/{userId}", Method.Put);
            var updatedInfo = new { name = "Quang promoted", job = "Senior QA" };
            reqUpdate.AddJsonBody(updatedInfo);
            var resUpdate = await client.PutAsync(reqUpdate);
            var resContent = JsonConvert.DeserializeObject<dynamic>(resUpdate.Content);
            Assert.Multiple(() =>
            {
                Assert.That(resUpdate.StatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(resContent.name.ToString(), Is.EqualTo(updatedInfo.name), "Assert name is updated");
                Assert.That(resContent.job.ToString(), Is.EqualTo(updatedInfo.job), "Assert job is updated");
            });

            //3. Delete user
            var reqDelete = new RestRequest($"/api/users/{userId}", Method.Delete);
            var resDelete = await client.DeleteAsync(reqDelete);
            Assert.That(resDelete.StatusCode, Is.EqualTo(HttpStatusCode.NoContent));
        }
    }
}

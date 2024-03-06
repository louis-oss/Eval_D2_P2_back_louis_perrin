using Eval_D2_P2_back_louis_perrin_Application.Services;
using Eval_D2_P2_back_louis_perrin_Core.Entities;
using System.Net;

namespace Eval_D2_P2_back_louis_perrin_Test
{
    public class UnitTest1
    {
        [Fact(DisplayName ="test AddEvent")]
        public void AddEvent_ReturnCreated()
        {
           
            var evenementService = new EvenementService();
            var evenement = new Evenement("test","test","test",DateTime.UtcNow);
           
           
            var result = evenementService.AddEvent(evenement);
     
            Assert.Equal(HttpStatusCode.Created, result.StatusCode);

        }

        [Fact(DisplayName = "test ListEvents")]
        public void ListEvents_ReturnOk()
        {
 
            var evenementService = new EvenementService();

            var result = evenementService.ListEvents();

            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
        }

        [Fact(DisplayName = "test UpdateEvent")]
        public void UpdateEvent_ReturnOk()
        {

            var evenementService = new EvenementService();
            var evenement = new Evenement("test", "test", "test", DateTime.UtcNow);

            var result = evenementService.UpdateEvent(evenement.Title, evenement);

            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
        }

        [Fact(DisplayName = "test DeleteEvent")]
        public void DeleteEvent_ReturnOk()
        {

            var evenementService = new EvenementService();
            var title = "title";

            var result = evenementService.DeleteEvent(title);

            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
        }
    }
}
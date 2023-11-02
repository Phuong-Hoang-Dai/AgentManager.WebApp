using AgentManager.WebApp.Models.Data;
using System.ComponentModel.DataAnnotations;

namespace AgentManager.WebApp.Models.ViewModel
{
    public class AddDeliveryNoteDetail
    {
        public int deliveryNoteId {  get; set; }
        public List<DeliveryNoteDetail> deliveryNoteDetails { get; set; } 
    }
}

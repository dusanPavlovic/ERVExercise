using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERV.Models
{
   public class PresencePreviewModel
    {
        public string PresenceEmpName { get; set; }
        public bool IsPresence { get; set; }


        public PresencePreviewModel()
        {

        }

        public PresencePreviewModel(bool isPresence, string presenceEmpName)
        {
            PresenceEmpName = presenceEmpName;

            IsPresence = isPresence;
        }

       
    }


}

using Lab1.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Models
{
    public class PC
    {
        public int Id { get; set; }
        public int? CaseId { get; set; }
        public int? CoolerId { get; set; }
        public int? CPUId { get; set; }
        public int? DataStorageId { get; set; }
        public int? GPUId { get; set; }
        public int? MotherboardId { get; set; }
        public int? PowerSupplyId { get; set; }
        public int? RAMId { get; set; }
        public decimal TotalSum { get; set; }


        // Кринж (НОООУ БИЛДЕР) конструктор
        public PC (int? сaseId, int? сoolerId, int? cpuId, int? dataStorageId, int? gpuId, int? motherboardId, int? powerSupplyId, int? ramId, decimal totalSum)
        {
            this.CaseId = сaseId;
            this.CoolerId = сoolerId;
            this.CPUId = cpuId;
            this.DataStorageId = dataStorageId;
            this.GPUId = gpuId;
            this.MotherboardId = motherboardId;
            this.PowerSupplyId = powerSupplyId;
            this.RAMId = ramId;
            this.TotalSum = totalSum;
        }

        public PC ()
        {

        }
    }
}

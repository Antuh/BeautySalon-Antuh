//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _20._101_02_BeautySalon.model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service()
        {
            this.ClientService = new HashSet<ClientService>();
            this.ServicePhoto = new HashSet<ServicePhoto>();
        }

    
        public int ID { get; set; }
        public string Title { get; set; }
        public string MainImagePath { get; set; }
        public int DurationInSeconds { get; set; }
        public decimal Cost { get; set; }
        public Nullable<double> Discount { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientService> ClientService { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServicePhoto> ServicePhoto { get; set; }
        public string ImgPath
        {
            get
            {
                var path = "/ImagesAndIcons/Услуги салона красоты/" + this.MainImagePath;
                return path;
            }
        }

        public int DurationInMin
        {
            get
            {
                return this.DurationInSeconds / 60;
            }
        }

        public double DiscountCost
        {
            get
            {
                if (Discount.HasValue)
                {
                    decimal result = Cost / 100;
                    return (double)(Cost - result * (decimal)this.Discount);
                }
                else return (double)Cost;
            }
        }

        public string DiscountText
        {
            get
            {
                if (this.Discount.HasValue) return $"*скидка {Discount}%";
                else return "";
            }
        }

        public string CostText
        {
            get
            {
                if (Discount.HasValue)
                {
                    double cost = (double)Cost;
                    return cost.ToString();
                }
                else return "";
            }
        }
    }
}


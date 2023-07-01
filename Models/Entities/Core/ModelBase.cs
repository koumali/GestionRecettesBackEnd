namespace automotiveApi.Models
{
    public partial class ModelBase
    {
        public int id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public DateTime? deleted_at { get; set; }
    }
}

namespace EF6Test2.Entities
{
    public class MaterialTranslation : BaseRemoteEntity<int>
    {
        public string CultureName { get; set; }

        public string LocalizedName { get; set; }

        public int MaterialId { get; set; }

        public Material Material { get; set; }
    }
}

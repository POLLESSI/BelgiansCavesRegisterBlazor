namespace BelgiansCavesRegisterBlazor.Client.Models
{
    public class SiteModel
    {
        public string Site_Name { get; set; }
        public string Site_Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public decimal Length { get; set; }
        public decimal Depth { get; set; }
        public string AccessRequirement { get; set; }
        public string PracticalInformation { get; set; }
        public LambdaDataModel LambdaData { get; set; }
        public NOwnerModel Owner { get; set; }
        public ScientificDataModel ScientificData { get; set; }
        public BibliographyModel Bibliography { get; set; }
        public bool Active { get; set; }
    }
}

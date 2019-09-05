namespace PropertyManagementSystem.Models
{
    internal class PropertyDocument
    {
        public int Id { get; set; }
        public DocumentType DocumentType { get; set; }
        public Property Property { get; set; }
        public int PropertyId { get; set; }
        public byte[] Image { get; set; }
    }

    internal enum DocumentType
    {
        BuildingImage = 1,
        OwnershipDoc = 2,
        BuildingDrawing = 3
    }
}

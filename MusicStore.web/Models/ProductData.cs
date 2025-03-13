using System;
namespace MusicStore.web.Models
{
    public class ProductData
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public int Id { get; set; }
        public int ProducerId { get; set; }
        public int BPM { get; set; }
        public string ImageUrl { get; set; }
        public string ReleaseDate { get; set; }
        public string ArtistName { get; set; }
        public string Scale { get; set; }
        public string AudioFileUrl { get; set; }
        public DateTime UploadDate { get; set; }
        public string License { get; set; }
        public int ArtistId { get; set; }
    }
}
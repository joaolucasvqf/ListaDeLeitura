using Api.DTO;
using System;

namespace Api.Models
{
    public class Livro
    {
        public Livro() { }
        public Livro(LivroDTO _DTO)
        {
            Id = _DTO.Id;
            Etag = _DTO.Etag;
            Title = _DTO.VolumeInfo.Title;
            Authors = _DTO.VolumeInfo.Authors;
            Thumbnail = _DTO.VolumeInfo.ImageLinks.Thumbnail;
            Description = _DTO.VolumeInfo.Description;
            Categories = _DTO.VolumeInfo.Categories;
        }
        public string Id { get; set; }
        public string Etag { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public Uri Thumbnail { get; set; }
        public string Description { get; set; }
        public string[] Categories { get; set; }
    }
}

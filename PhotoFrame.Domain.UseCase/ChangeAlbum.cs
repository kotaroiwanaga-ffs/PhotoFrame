using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoFrame.Domain.Model;

namespace PhotoFrame.Domain.UseCase
{
    class ChangeAlbum
    {
        private readonly IAlbumRepository albumRepository;

        public ChangeAlbum(IAlbumRepository repository)
        {
            this.albumRepository = repository;
        }

        public void Execute(string albumTitle)
        {
            var album = Album.Create(albumTitle);
            albumRepository.Store(album);
        }
    }
}

using AspNetCore2.Entities;
using System.Collections.Generic;

namespace AspNetCore2.Services
{
    public interface IVideoData
    {
        IEnumerable<Video> GetAll();
        Video Get(int id);
        void Add(Video newVideo);
        int Commit();
    }
}

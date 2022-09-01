
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace UltimateTeamApi.Data
{
    public class Result<T>
    {
        public int PageIndex { get; private set; }
        public int PageSize { get; private set; }
        public int TotalCount { get; private set; }
        public int TotalPages { get; private set; }
        public List<T> Data { get; private set; }


        private Result(int pageIndex, int pageSize, int count, List<T> data)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalCount = count;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            Data = data;
        }
        public static async Task<Result<T>> CreateAsync(int pageIndex, int pageSize, IQueryable<T> source)
        {
            var count = await source.CountAsync();

            source = source.Skip(pageIndex * pageSize).Take(pageSize);

            var data = await source.ToListAsync();


            return new Result<T>(pageIndex, pageSize, count, data);
        }
        public bool HasPreviousPage
        {
            get
            {
                return PageIndex > 0;
            }
        }
        public bool HasNextPage
        {
            get
            {
                return PageIndex + 1 < TotalPages;
            }
        }

    }
}

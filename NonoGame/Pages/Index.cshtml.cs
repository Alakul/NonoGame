using NonoGame.DatabaseContext;
using NonoGame.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NonoGame.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        readonly AppDbContext db;
        private Random random = new Random();
        public Nonogram Nonogram { get; set; }

        public IndexModel(ILogger<IndexModel> logger, AppDbContext context)
        {
            _logger = logger;
            db = context;
        }

        public void OnGet()
        {
            int elements = db.Nonogram.ToList().Count();
            if (elements > 0){
                List<int> list = GetIds();
                int intValue = random.Next(list.Count);
                Nonogram = db.Nonogram.Where(x => x.Id == list[intValue]).Single();
            }
            else {
                int[] array = new int[]{ 0, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0 };
                Nonogram.Size = 5;
                Nonogram.Data = array;
            }
        }

        private List<int> GetIds()
        {
            List<int> idValues = new List<int>();
            List<Nonogram> nonogramList = db.Nonogram.ToList();
            for (int i=0; i<nonogramList.Count; i++)
            {
                idValues.Add(nonogramList[i].Id);
            }

            return idValues;
        }
    }
}
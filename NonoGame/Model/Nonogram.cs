using System.ComponentModel.DataAnnotations.Schema;

namespace NonoGame.Model
{
    public class Nonogram
    {
        public int Id { get; set; }

        [NotMapped]
        public int[] Data
        {
            get
            {
                return Array.ConvertAll(Image.Split(';'), int.Parse);
            }
            set
            {
                Image = string.Join(";", Data.ToArray());
            }
        }
        public int Size { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }
    }
}

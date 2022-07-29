namespace Wordle.Models.Interfaces
{
    public interface IShape
    {
        public int Id { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        /// <summary>
        /// Sets the id.
        /// </summary>
        /// <param name="id"></param>
        public void SetId();
    }
}

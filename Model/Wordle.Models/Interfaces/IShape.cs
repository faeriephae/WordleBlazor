using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

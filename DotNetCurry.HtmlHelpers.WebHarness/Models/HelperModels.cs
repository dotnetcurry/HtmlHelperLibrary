using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetCurry.HtmlHelpers.WebHarness.Models
{
    public class TwoDimensionalData
    {
        public int Id { get; set; }
        private List<int[]> _data;

        public List<int[]> Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public TwoDimensionalData()
        {
            _data = new List<int[]>();

        }

    }
}
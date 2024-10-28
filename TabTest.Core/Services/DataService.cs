using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabTest.Core.Models;

namespace TabTest.Core.Services
{
    public interface IDataService
    {
        public TestData Data { get; set; }
    }

    internal class DataService : IDataService
    {
        public DataService()
        {
            Data = new TestData
            {
                Title = "Tab Test Data",
                Items = new System.Collections.ObjectModel.ObservableCollection<TestDataItem>
                {
                    new TestDataItem
                    {
                        Description = "Tab 1 Data 1",
                        TabNo = 1
                    },
                    new TestDataItem
                    {
                        Description = "Tab 1 Data 2",
                        TabNo = 1
                    },
                    new TestDataItem
                    {
                        Description = "Tab 1 Data 3",
                        TabNo = 1
                    },
                    new TestDataItem
                    {
                        Description = "Tab 1 Data 4",
                        TabNo = 1
                    },
                    new TestDataItem
                    {
                        Description = "Tab 2 Data 1",
                        TabNo = 2
                    },
                    new TestDataItem
                    {
                        Description = "Tab 2 Data 2",
                        TabNo = 2
                    },
                    new TestDataItem
                    {
                        Description = "Tab 2 Data 3",
                        TabNo = 2
                    },
                    new TestDataItem
                    {
                        Description = "Tab 2 Data 4",
                        TabNo = 2
                    },
                    new TestDataItem
                    {
                        Description = "Tab 3 Data 1",
                        TabNo = 3
                    },
                    new TestDataItem
                    {
                        Description = "Tab 3 Data 2",
                        TabNo = 3
                    },
                    new TestDataItem
                    {
                        Description = "Tab 3 Data 3",
                        TabNo = 3
                    },
                    new TestDataItem
                    {
                        Description = "Tab 3 Data 4",
                        TabNo = 3
                    },
                    new TestDataItem
                    {
                        Description = "Tab 4 Data 1",
                        TabNo = 4
                    },
                    new TestDataItem
                    {
                        Description = "Tab 4 Data 2",
                        TabNo = 4
                    },
                    new TestDataItem
                    {
                        Description = "Tab 4 Data 3",
                        TabNo = 4
                    },
                    new TestDataItem
                    {
                        Description = "Tab 4 Data 4",
                        TabNo = 4
                    }
                }


            };
        }

        public TestData Data { get; set; }



    }
}

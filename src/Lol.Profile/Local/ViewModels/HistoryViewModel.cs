﻿using Lol.Data.History;
using Lol.ExampleData.History;
using Lol.Foundation.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lol.Profile.Local.ViewModels
{
    public class HistoryViewModel : ObservableObject
    {
		#region Variables

		private List<HistoryModel> _historys;
		#endregion 

		#region Historys

		public List<HistoryModel> Historys
        {
            get { return _historys; }
            set { _historys = value; OnPropertyChanged(); }
        }
		#endregion

		#region Constructor

		public HistoryViewModel()
		{
			Historys = ExamHistory.GetHistory();
		}
		#endregion

	}
}

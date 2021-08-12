using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UIBaseProject.Pages
{
	public partial class StepsPage
	{
		private string _selectedStep;

		protected override void OnInitialized()
		{
			_selectedStep = "accountStep";
		}
	}
}

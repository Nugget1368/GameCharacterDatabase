using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacterDatabase.Shared.Models
{
	public class ResultModel<T>
	{
		public T? Result { get; set; }
		public string ResultMessage { get; set; } = string.Empty;
		public bool Success { get; set; }
	}
}

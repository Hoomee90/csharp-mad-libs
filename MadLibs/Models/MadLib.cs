namespace MadLibs.Models
{
	public class MadLib
	{
		public string[] Words { get; set; }
		
		public MadLib(string[] words)
		{
			Words = words;
		}
	}
}
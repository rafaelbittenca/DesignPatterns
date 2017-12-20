namespace MoreExamplesFactory.Example02
{
	//Concrete product
	class SamsungGuru : INormalPhone
	{
		public string GetModelDetails()
		{
			return "Model: Samsung Guru\nRAM: NA\nCamera: NA\n";
		}
	}
}
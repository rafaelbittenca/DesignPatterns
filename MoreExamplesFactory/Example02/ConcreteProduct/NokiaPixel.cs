namespace MoreExamplesFactory.Example02
{
	//Concrete Product
	class NokiaPixel : ISmartPhone
	{
		public string GetModelDetails()
		{
			return "Model: Nokia Pixel\nRAM: 3GB\nCamera: 8MP\n";
		}
	}
}
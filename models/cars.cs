using System;
using System.ComponentModel.DataAnnotations;

namespace gregslist_dotnet.models
{
  public class Car
  {
    //faking id's for now
    public string Id { get; set; }
    // dataAnnotations apply to value below them
    [Required]
    public string Make { get; set; }
    [Required]
    public string Model { get; set; }
    [Required]
    public int Year { get; set; }
    [Required]
    public int Price { get; set; }
    public string Description { get; set; }
    public string ImgUrl { get; set; }
    public Car(string make, string model, int year, int price, string imgUrl = "https://placehold.it/200x200", string description = "no description given")
    {
      Make = make;
      Model = model;
      Year = year;
      Price = price;
      Description = description;
      ImgUrl = imgUrl;
      Id = Guid.NewGuid().ToString();
    }
  }
}
// make: { type: String, required: true },
// model: { type: String, required: true },
// year: { type: Number, required: true },
// price: { type: Number, required: true, default: 0 },
// description: { type: String, default: 'No Description Provided' },
// imgUrl: { type: String, default: 'https://placehold.it/200x200' },
// pictures: [{ type: String }]
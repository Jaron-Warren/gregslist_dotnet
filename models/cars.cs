namespace gregslist_dotnet.models
{
  public class Car
  {
    //faking id's for now
    public string Id { get; set; }
    // dataAnnotations apply to value below them
    public string Name { }
  }
}
// make: { type: String, required: true },
// model: { type: String, required: true },
// year: { type: Number, required: true },
// price: { type: Number, required: true, default: 0 },
// description: { type: String, default: 'No Description Provided' },
// imgUrl: { type: String, default: 'https://placehold.it/200x200' },
// pictures: [{ type: String }]
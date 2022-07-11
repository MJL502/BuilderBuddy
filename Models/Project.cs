using BuilderBuddy.Models;
using System.ComponentModel.DataAnnotations;

namespace BuilderBuddy.Models;

public class Project

{
    
[Key]
public int ProjectID { get; set; }

public string? ProjectName  { get; set; }

public DateTime ProjectDate  { get; set; }

public int? NumberOfRooms { get; set; }

public List<Room>? Rooms { get; set; }

public decimal? TotalCost { get; set; }

//public static MvcHtmlString TextBoxFor<TModel, TProperty>(this HtmlHelper<TModel>> htmlHelper, Expression<Func<TModel, TProperty>> expression, object htmlAttributes);

}
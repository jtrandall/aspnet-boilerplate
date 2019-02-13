# aspnet-boilerplate
Boilerplate ASP.NET project. Contains inline examples, patterns and helper classes. 

### CamelCaseControllerConfigAttribute
This method can be added to your project to ensure that the results for the class that is decorated with attribute will be in json format and camelCased.

```csharp
[Route("api/sample")]
[CamelCaseControllerConfig]
public class SampleApiController : ApiController
{
    public IHttpActionResult Get()
    {
        var results = new List<Person>
        {
            new Person { Name = "Henry Smith", Address="403 Main Street" },
            new Person { Name = "Julie Vasquez", Address="931 Starks Street" },
            new Person { Name = "Holly Ford", Address="192 Hillside Boulevard" }
        };

        return Ok(results);
    }
}
```
This will return (note that the property names are camel-cased)
```json
[
    {
        "name": "Henry Smith",
        "address": "403 Main Street"
    },
    {
        "name": "Julie Vasquez",
        "address": "931 Starks Street"
    },
    {
        "name": "Holly Ford",
        "address": "192 Hillside Boulevard"
    }
]
```

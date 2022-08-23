namespace CoursesApi.Controllers;

public class CoursesController : ControllerBase
{

    [HttpGet("/courses")]
    public async Task<ActionResult<CoursesResponse>> GetAllCoursesAsync()
    {
        var response = new CoursesResponse();

        return Ok(response);
        
    }

    [HttpGet("/courses/{courseId}")]
    public async Task<ActionResult<CourseDetailsResponse>> GetCourseByIdAsync(string courseId)
    {
        if(courseId == "Dance")
        {
            return NotFound();
        } else
        {
            var response = new CourseDetailsResponse
            {
                Id = courseId,
                Title = "Underwater basket Weaving",
                DeliveryLocation = DeliveryLocationTypes.Online,
                NumberOfHours = 323.5M
            };
            return Ok(response);
        }
    }
}

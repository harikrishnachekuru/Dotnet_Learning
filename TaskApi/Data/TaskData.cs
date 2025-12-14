using TaskApi.Models;

namespace TaskApi.Data
{
    public static class TaskData
    {
        public static List<TaskModel> Tasks = new()
        {
            new TaskModel
            {
                Id = "Task-1",
                Title = "Title",
                Description = "Description",
                Dependencies = new List<string> {"Task-2", "Task-3"},
                CreatedAt = DateTime.Parse("2023-12-23T12:00:00Z"),
                UpdatedAt = DateTime.Parse("2023-12-23T12:00:00Z")
            },

            new TaskModel
            {
                Id = "Task-2",
                Title = "Title",
                Description = "Description",
                Dependencies = new List<string> {"Task-4"},
                CreatedAt = DateTime.Parse("2023-12-23T12:00:00Z"),
                UpdatedAt = DateTime.Parse("2023-12-23T12:00:00Z")
            },

            new TaskModel
            {
                Id = "Task-3",
                Title = "Title",
                Description = "Description",
                Dependencies = new (),
                CreatedAt = DateTime.Parse("2023-12-23T12:00:00Z"),
                UpdatedAt = DateTime.Parse("2023-12-23T12:00:00Z")
            },

            new TaskModel
            {
                Id = "Task-4",
                Title = "Title",
                Description = "Description",
                Dependencies = new (),
                CreatedAt = DateTime.Parse("2023-12-23T12:00:00Z"),
                UpdatedAt = DateTime.Parse("2023-12-23T12:00:00Z")
            }
        };
    }
}
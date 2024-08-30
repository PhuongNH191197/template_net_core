# template_net_core
# Layered Architecture
# 1.Presentation Layer (Tầng trình bày):
## API Controllers: Chứa các controller xử lý các yêu cầu HTTP từ client và trả về các phản hồi tương ứng.
## View Models/DTOs: Các đối tượng chuyển đổi dữ liệu giữa các tầng.

# 2.Business Logic Layer (Tầng logic nghiệp vụ):
## Services: Chứa các logic nghiệp vụ của ứng dụng.
## Business Rules/Policies: Các quy tắc nghiệp vụ, điều kiện hoặc logic tùy thuộc vào yêu cầu cụ thể.

# 3.Data Access Layer (Tầng truy cập dữ liệu):

## Repositories: Các lớp hoặc interface quản lý truy cập dữ liệu, tương tác với cơ sở dữ liệu hoặc các nguồn dữ liệu khác.
## Entities/Models: Các đối tượng đại diện cho dữ liệu được lưu trữ.
## Infrastructure Layer (Tầng cơ sở hạ tầng):

# 4.Database Context: Sử dụng Entity Framework Core hoặc các ORM khác để truy cập và quản lý cơ sở dữ liệu.
## Logging, Caching: Các dịch vụ hạ tầng khác như logging, caching, hoặc message queuing.
======EN======
Presentation Layer (TodoAPI.Presentation):

Receives HTTP requests from clients (e.g., web browsers, mobile apps).
Routes requests to appropriate controller actions based on the request URL and HTTP method.
Interacts with the Services Layer to perform business logic operations.
Services Layer (TodoAPI.Services):

Contains business logic and service classes responsible for handling application logic.
Receives requests from the Presentation Layer and performs necessary operations.
Utilizes the Data Access Layer to interact with the database to retrieve, create, update, or delete data.
Returns data or results to the Presentation Layer for further processing or rendering.
Models:

Defines the structure of domain objects (e.g., Todo class).
Represents entities and data transfer objects (DTOs) used throughout the application.
Provides a common understanding of data structures across layers.
Data Access Layer (TodoAPI.DataAccess):

Handles data access operations and interacts with the database.
Contains the database context (TodoDbContext) that represents the database schema and provides access to entities (e.g., Todo).
Executes database queries and updates using Entity Framework Core.
Maps database entities to domain models and vice versa.
Dependency Injection (Program.cs):

Configures dependency injection to inject dependencies into controllers and other classes.
Registers services and their implementations, allowing them to be resolved and used throughout the application.
Manages the lifetime of service instances, ensuring proper scope and disposal.


================ Migration DB ==================
1. dotnet ef migrations add initial --project .\API.DataAccess
2. dotnet ef database update --project .\API.DataAccess 

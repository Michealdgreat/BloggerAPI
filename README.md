# BloggerAPI 

- Welcome to the BloggerAPI project, a solution for managing your blogging platform efficiently. This project leverages ASP.NET Core, along with SQL, Stored procedures, Dapper, and MediatR. 

## Project Overview 📋
BloggerAPI offers an effective way to manage blog posts and categories, providing essential CRUD functionalities:

- **SQL & Stored Procedures:** The backend is built on a robust SQL database, utilizing stored procedures for efficient data management.
- **Dapper:** Dapper is integrated for lightweight, fast data access, allowing seamless database interaction.
- **MediatR:** MediatR simplifies handling commands and queries, resulting in a more maintainable and testable codebase.
- **MVC Frontend:** An ASP.NET MVC application is included in the same solution, serving as the frontend for consuming the BloggerAPI, providing a user-friendly interface.
- **Docker:** Both the API and MVC projects are containerized with Docker, making the entire solution ready for deployment.

## Download Database scripts here  [Infrastructure/DatabaseScripts](Infrastructure/DatabaseScripts)


## DependencyGraph
![GRAPH](Infrastructure/DatabaseScripts/DependencyGraph.jpg "Dependency Graph")

### Conclusion

The BloggerAPI project provides a comprehensive solution for managing your blogging platform. With its backend built on ASP.NET Core, SQL, and stored procedures, along with the lightweight data access of Dapper and structured command handling of MediatR, it's designed for both performance and maintainability. The inclusion of an ASP.NET MVC frontend, integrated into the same solution and containerized with Docker, makes this project ready for deployment and use.

If you have any questions, feel free to reach out, and happy blogging! 😊

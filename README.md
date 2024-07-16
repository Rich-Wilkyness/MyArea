# Team 6
## Project Name: Innovators
## Team Members: 
1. Christian Wilkerson
2. Jonah West
3. Victor Elerunndu
4. Thompson Nkomo
5. Alyssa Lahoy
6. Fernando Arias

# Brainstroming Ideas

## Title: My Area

## Overview:
1) Purpose / Goals: Customizable Blogsite for users to create their own personal blog. 
2) Problem Solved: Lonely people who want to share their thoughts and ideas with the world.
3) Target Audience: People who want to have a personal website that they can customize to their liking.

## Scope:
1) Features and Functionality:
    - Register, Login, and Profile Page, Authentication and Authorization
    - landing page drop down menu of blog categories that will filter the blogs displaying Blog Title, Author, Date, and maybe a brief description.
    - Profile Page: Edit, Delete, List of personal blogs, create new blog
    - Branding: 
        - Color Scheme: Shades of Blue and white
        - Logo: whatever ai gives us
        - Font: Playwright New Zealand
    - Navigation: Home, Profile, User Docs, Contact Us
2) Technical Stack:
    - Fontend: C# Blazor WebAssembly, HTML, CSS, Bootstrap
    - Backend: C# ASP.NET Core 
    - Database: SQL Server (SQLite), Do we care to use something different for development vs production? Netlify for production?
    - Repository: Azure DevOps
    - Deployment: Cloud Services
3) Deliverables: (ex: a completed website, a completed mobile app, a completed API, etc.)
    - A completed website with a user-friendly interface that allows users to create and customize their own personal blog.
4) Boundaries: (ex: what the project will not do: ex: will not include a payment system, Limiting a research project to specific geographical areas or demographics.)
    - Will not include a payment system
    - Will not include a chat feature
    - Will not include a search feature but a filter feature instead

## Functional Requirements:
1) User Interactions:
    - CRUD on User Profile: Register, Login, Update, Delete
    - CRUD on Blogs: Create, Read, Update, Delete
    - Filter Blogs by Category
    - Visit home page, profile page, user docs, contact us
2) System Tasks (ex: Automatically sending a confirmation email after a user registers, Processing a payment transaction, Generating a report based on user-selected criteria):
    - Send confirmation after user registers or logs in 
    - Generate a report based on user-selected criteria
3) Data Management (ex: data processing, data storage, data retrieval, Implementing backups and data recovery processes, Ensuring data privacy through encryption and access controls):
    - Store User Information: Name, Email, Password, Font, Color Scheme, etc.
    - Store Blog Information: Title, Author FK to UserID, Date, Description, Content, Font, Color Scheme, etc.
4) Security: 
    - Authentication and Authorization 

## Non-Functional Requirements:
1) Performance: Yes
2) Usability:
    - [User Documentation](https://technicalwriterhq.com/documentation/user-documentation/#:~:text=User%20documentation%2C%20also%20known%20as%20end-user%20documentation%2C%20is,to%20properly%20install%2C%20use%2C%20and%2For%20troubleshoot%20a%20product)
    - aria labels for screen readers
3) Reliability:
    - Unit Test 20% of code that is likely to break
4) Scalability: Yes 
5) Maintainability:
    - [Code Comments](https://www.techtarget.com/searchsoftwarequality/tip/Code-comment-best-practices-every-developer-should-know)

# Introduction 

# Getting Started
TODO: Guide users through getting your code up and running on their own system. In this section you can talk about:
1.	Installation process
2.	Software dependencies
3.	Latest releases
4.	API references

# Build and Test
TODO: Describe and show how to build your code and run the tests. 

# Contribute
TODO: Explain how other users and developers can contribute to make your code better. 

If you want to learn more about creating good readme files then refer the following [guidelines](https://docs.microsoft.com/en-us/azure/devops/repos/git/create-a-readme?view=azure-devops). You can also seek inspiration from the below readme files:
- [ASP.NET Core](https://github.com/aspnet/Home)
- [Visual Studio Code](https://github.com/Microsoft/vscode)
- [Chakra Core](https://github.com/Microsoft/ChakraCore)
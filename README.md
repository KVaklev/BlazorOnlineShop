# Blazor_Online_Shop

Welcome to the Blazor Online Fishing Shop! 
A simple application crafted to display current availability of the products offered by the shop along with some additional details such as unit price, units in stock, delivery date and an image of each product
This project is built with the Blazor framework without incorporating extended functionalities like cart management or order processing.

## Technical details

# Hosting Model
The model chosen for this project is Blazor Web Assembly as the application have reduced server dependency.

Pros:
- Blazor WebAssembly allows the entire application to run on the client's browser after being downloaded. It compiles the C# code into WebAssembly, which runs in the browser.
- Performance: As the server isn't handling UI updates, it can handle more clients with less demand on server resources.

Cons:
- Initial Load Time: The initial load time might be longer due to larger file sizes and the need to download the entire application to the client's device.

# Framework and Resources
Utilized the Blazor framework for front-end development. 
Experimented with styling and structuring the product list:
 - Employed various components and structures to present the product list, potentially integrating images to enrich the display.
 - Implemented visual indicators distinguishing products available in stock from those out of stock.

## Feature

1. A custom collection of products was utilized for the data representation.

2. The user can seamlessly scrolling through the list of products by clicking on the "Products" on the home page.

3."About" section brings the user to the Microsoft documentaion and particularly "Build your first web app with ASP.NET Core using Blazor" - https://dotnet.microsoft.com/en-us/learn/aspnet/blazor-tutorial/intro

## How to Set Up and Run the Project Locally - follow these steps:

1. Clone the GitHub Repository
2. Install Dependencies and Packages
3. Build and Run the Project - use the appropriate commands to build and run the project.
4. Access the Application - once the project is running locally, you can access the application by opening a web browser and entering the appropriate URL.

## Project Hierarchy and Entity Descriptions

| Section         | Component       | Description                                                                                                 |
| --------------- | --------------- | ----------------------------------------------------------------------------------------------------------- | 
| 1. Layout       | MainLayout.razor| Both razor components were customized on top of the default template to arrange the visualizion		      |
|                 | NavMenu.razor   |  																											  |     
|                 |                 |            																								  |
|                 |                 |                                                                                                             |
| 2. Pages        | FetchData.razor | In this Blazor page, the 'Products' section is presented, displaying a table of product details including   |                                                                                                           |
|                 |   Home.razor    | ID, name, price, stock availability, delivery date, and images.										   	  |															  |
|		          |					| The table supports pagination, allowing users to navigate through the available products with a default     |                                       |
|		          |					| display of 7 products per page. It also visually highlights products out of stock by marking them with a    |
|		          |					| red background.																							  |
|		          |					|                                                                                                             |
|                 |                 |                                                                                                             |
| 3. Service      |ProductService.cs| The ProductService class in the Blazor Online Shop project handles the retrieval of product information     |
|				  |		            | asynchronously. Using the GetProductsAsync method, it emulates a delay and returns a collection of products,|
|                 |	                | each containing details such as ID, name, price, stock availability, delivery dates, and respective image   |
|                 |                 | URLs.											                  |
				                                  									          
## Credits

This project was created by Kristian Vaklev:

| Contacts        | Email                     |
| --------------- | ------------------------- |
| Kristian Vaklev | kristian.vaklev@yahoo.com |



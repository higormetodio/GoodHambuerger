# GoodHambuerger - API
This is an API that aims to send customer orders for sandwiches, such as X-Burger, and extras, such as French Fries and Soda.


## Rules
Some rules must be followed:
- If the customer selects a sandwich, fries, and soft drink, then the customer will have 20% discount. 
- If the customer selects a sandwich and soft drink, then the customer will have 15% discount. 
- If the customer selects a sandwich and fries, then the customer will have a 10% discount. 
- Each order cannot contain more than one sandwich, fries, or soda. If two identical items are sent, the API should return an error message displaying the reason.
- When sending an order, the amount that will be charged to the customer must be returned.


## API Technologies
The GoodHamburger - API was built using .NET Core 8.0 with C#, ASP.NET WebAPI MinimalApi and in-memory database with Entity Framework InMemory


## Patterns and Concepts
The concept of clean architecture was used, separating the layers into API, Application, Domain and Infrastructure
![image](https://github.com/user-attachments/assets/a7baaa28-30ea-4af8-a8ea-0395c18f0a31)

The result pattern was also used to standardize the sending of information and messages.


## Main endpoints
- Create Orders - It is possible to add the order item IDs to a list, where the order total will be returned.
  ![image](https://github.com/user-attachments/assets/cc7c9cee-f496-4e97-9a29-e959c49f2d9b)
- List Orders - It is possible to list all orders.
  ![image](https://github.com/user-attachments/assets/2b161d53-7154-46dd-95bc-7a9f20e29dc6)
- Update Order - It is possible to update a specific order.
  ![image](https://github.com/user-attachments/assets/0b032225-e9e4-4883-9fc1-1abefc8f0c54)
- Remove Order - It is possible to delete a specific order by id.
  ![image](https://github.com/user-attachments/assets/cded3a5d-9111-4515-b91a-2fc7c876db2b)
- List Items - It is possible to list all items sandwiches and extras.
  ![image](https://github.com/user-attachments/assets/a314f0a9-6a20-4dd4-bf49-61386bf171e2)
- List Items Sandwiches - It is possible to list all items of the sandwich type only..
  ![image](https://github.com/user-attachments/assets/9b35544b-0450-4ccc-8ca9-016a4478b3a6)
- List Items Extras - It is possible to list all items of the extra type only..
  ![image](https://github.com/user-attachments/assets/71ca43a8-8e8c-4f88-b962-4e255eafe163)


## Running the API
-  Clone the respoitory
    ```
      git clone https://github.com/higormetodio/GoodHambuerger.git
    ```
- Run the API
    ```
      dotnet watch run
    ```




```mermaid

erDiagram
    Product {
        INT ID PK
        VARCHAR Name
        DECIMAL Price
        VARCHAR Image
        BIT IsActive
    }
    User {
        INT ID PK
        VARCHAR Login
        VARCHAR Password
        ENUM Type "Admin, Casual"
        BIT IsActive
    }
    BasketPosition {
        INT ID PK
        INT ProductID FK
        INT UserID FK
        INT Amount
    }
    Order {
        INT ID PK
        INT UserID FK
        DateTime Date
    }
    OrderPosition {
        INT ID PK
        INT OrderID FK
        INT ProductID FK
        INT Amount
        DECIMAL Price
    }
    Product ||--o{ BasketPosition : ""
    User ||--o{ BasketPosition : ""
    User ||--o{ Order : ""
    Order ||--o{ OrderPosition : ""


```

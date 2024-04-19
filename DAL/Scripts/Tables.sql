use stgshopflow_

-- User Authentication and Authorization
CREATE TABLE Users (
    UserID INT PRIMARY KEY,
    Username NVARCHAR(50),
    Email NVARCHAR(100) unique,
    PasswordHash NVARCHAR(100) -- Store hashed passwords securely
);

-- Role Management
CREATE TABLE Roles (
    RoleID INT PRIMARY KEY,
    RoleName NVARCHAR(50) UNIQUE
);

-- Permissions Management
CREATE TABLE Permissions (
    PermissionID INT PRIMARY KEY,
    PermissionName NVARCHAR(50) UNIQUE
);

-- Role-Permission Mapping
CREATE TABLE RolePermissions (
    RoleID INT,
    PermissionID INT,
    PRIMARY KEY (RoleID, PermissionID),
    FOREIGN KEY (RoleID) REFERENCES Roles(RoleID),
    FOREIGN KEY (PermissionID) REFERENCES Permissions(PermissionID)
);

-- User-Role Mapping
CREATE TABLE UserRoles (
    UserID INT,
    RoleID INT,
    PRIMARY KEY (UserID, RoleID),
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (RoleID) REFERENCES Roles(RoleID)
);

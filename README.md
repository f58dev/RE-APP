# Real Estate App (REA)

## Overview
Real Estate App (REA) is a full-stack web application designed to simplify the process of searching, listing, and managing properties. It serves both real estate buyers and sellers with a user-friendly interface and powerful features such as property filtering, image uploads, interactive maps, and secure user authentication.

## Features
- User authentication and role-based access (buyers, sellers, admins)
- Property listing with:
  - Title, description, price, location, images
  - Category (e.g., rent/sale), type (apartment, villa, etc.)
- Search and filter properties by multiple criteria
- Contact forms and booking requests
- Admin dashboard for managing listings and users
- Responsive design for desktop and mobile
- Map integration (Google Maps or Leaflet)

## Technologies Used
**Frontend:**
- React.js (with React Router & Context API)
- Tailwind CSS or Bootstrap

**Backend:**
- C# (ASP.NET Core Web API)
- Entity Framework Core
- SQL Server or PostgreSQL

**Other Tools:**
- JWT Authentication
- Cloudinary or Firebase for image storage
- Git & GitHub for version control
- Postman for API testing

## Installation

### Frontend
```bash
cd frontend
npm install
npm run dev
```

### Backend
```bash
cd backend
dotnet restore
dotnet run
```

## Environment Variables

### `.env` (Frontend)
```
VITE_API_URL=http://localhost:5000/api
```

### `appsettings.json` (Backend)
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=REA;User Id=youruser;Password=yourpassword;"
}
```

## Roadmap
- [x] User registration & login
- [x] Add new property listing
- [x] Display property details
- [ ] Implement real-time chat between buyers and sellers
- [ ] Add multi-language support
- [ ] Integrate payment gateway for premium listings

## License
This project is licensed under the MIT License.

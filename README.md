# YouTube Suggestions - Full Stack Application

A modern full-stack application built with .NET Web API and React TypeScript, featuring a beautiful YouTube-style suggestions interface.

## 🚀 Features

- **Backend API**: .NET 8 Web API with CORS support
- **Frontend**: React TypeScript with modern UI/UX
- **Responsive Design**: Works on desktop and mobile devices
- **Real-time Data**: Fetches suggestions from the API
- **Beautiful UI**: Modern gradient design with hover effects

## 📁 Project Structure

```
YoutubeSuggestions/
├── YoutubeSuggestions.sln          # Main solution file
├── YoutubeSuggestions.Api/         # .NET Web API backend
│   ├── Program.cs                  # API configuration and endpoints
│   ├── appsettings.json           # API configuration
│   └── YoutubeSuggestions.Api.csproj
└── youtube-suggestions-client/     # React TypeScript frontend
    ├── src/
    │   ├── App.tsx                # Main React component
    │   ├── App.css                # Modern styling
    │   └── index.tsx              # React entry point
    ├── package.json               # React dependencies
    └── tsconfig.json              # TypeScript configuration
```

## 🛠️ Prerequisites

- **.NET 8 SDK** - [Download here](https://dotnet.microsoft.com/download/dotnet/8.0)
- **Node.js** (v16 or higher) - [Download here](https://nodejs.org/)
- **npm** or **yarn** package manager

## 🚀 Getting Started

### 1. Clone and Setup

```bash
# Navigate to the project directory
cd YoutubeSuggestions

# Restore .NET dependencies
dotnet restore

# Install React dependencies
cd youtube-suggestions-client
npm install
cd ..
```

### 2. Run the Backend API

```bash
# Navigate to the API directory
cd YoutubeSuggestions.Api

# Run the API (will start on https://localhost:7175)
dotnet run
```

The API will be available at:
- **API Endpoints**: https://localhost:7175
- **Swagger UI**: https://localhost:7175/swagger

### 3. Run the React Frontend

Open a new terminal window and run:

```bash
# Navigate to the React app directory
cd youtube-suggestions-client

# Start the development server (will start on http://localhost:3000)
npm start
```

The React app will automatically open in your browser at: http://localhost:3000

## 📡 API Endpoints

### GET /api/suggestions
Returns all YouTube video suggestions.

**Response:**
```json
[
  {
    "id": 1,
    "title": "How to Build a React App",
    "channel": "CodeMaster",
    "views": "1.2M",
    "thumbnail": "https://via.placeholder.com/120x90"
  }
]
```

### GET /api/suggestions/{id}
Returns a specific suggestion by ID.

## 🎨 Features

### Frontend Features
- **Modern UI**: Beautiful gradient background with glassmorphism effects
- **Responsive Design**: Adapts to different screen sizes
- **Loading States**: Smooth loading animations
- **Error Handling**: User-friendly error messages with retry functionality
- **Hover Effects**: Interactive cards with smooth animations
- **TypeScript**: Full type safety

### Backend Features
- **CORS Support**: Configured for React app communication
- **Swagger Documentation**: Auto-generated API documentation
- **RESTful Endpoints**: Clean API design
- **Error Handling**: Proper HTTP status codes

## 🔧 Development

### Adding New Features

1. **Backend**: Add new endpoints in `YoutubeSuggestions.Api/Program.cs`
2. **Frontend**: Update components in `youtube-suggestions-client/src/`

### Styling
- CSS is located in `youtube-suggestions-client/src/App.css`
- Uses modern CSS features like Grid, Flexbox, and CSS animations
- Responsive design with mobile-first approach

## 🚀 Deployment

### Backend Deployment
```bash
# Build for production
dotnet publish -c Release

# Deploy to your preferred hosting platform (Azure, AWS, etc.)
```

### Frontend Deployment
```bash
# Build for production
cd youtube-suggestions-client
npm run build

# Deploy the build folder to your preferred hosting platform
```

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Test both frontend and backend
5. Submit a pull request

## 📝 License

This project is open source and available under the [MIT License](LICENSE).

## 🆘 Troubleshooting

### Common Issues

1. **CORS Errors**: Make sure the API is running on the correct port (7175)
2. **Port Conflicts**: If port 3000 is in use, React will automatically use the next available port
3. **SSL Certificate**: The API uses HTTPS with a development certificate. Accept the certificate warning in your browser

### Getting Help

If you encounter any issues:
1. Check that all prerequisites are installed
2. Ensure both API and React app are running
3. Check the browser console for any JavaScript errors
4. Verify the API endpoints are accessible via Swagger UI

---

**Happy Coding! 🎉** 
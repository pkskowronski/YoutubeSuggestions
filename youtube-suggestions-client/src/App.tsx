import React, { useState, useEffect } from 'react';
import './App.css';

interface YouTubeSuggestion {
  id: number;
  title: string;
  channel: string;
  views: string;
  thumbnail: string;
}

function App() {
  const [suggestions, setSuggestions] = useState<YouTubeSuggestion[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    fetchSuggestions();
  }, []);

  const fetchSuggestions = async () => {
    try {
      setLoading(true);
      const response = await fetch('https://localhost:7175/api/suggestions');
      if (!response.ok) {
        throw new Error('Failed to fetch suggestions');
      }
      const data = await response.json();
      setSuggestions(data);
    } catch (err) {
      setError(err instanceof Error ? err.message : 'An error occurred');
    } finally {
      setLoading(false);
    }
  };

  if (loading) {
    return (
      <div className="App">
        <div className="loading">
          <div className="spinner"></div>
          <p>Loading suggestions...</p>
        </div>
      </div>
    );
  }

  if (error) {
    return (
      <div className="App">
        <div className="error">
          <h2>Error</h2>
          <p>{error}</p>
          <button onClick={fetchSuggestions} className="retry-btn">
            Try Again
          </button>
        </div>
      </div>
    );
  }

  return (
    <div className="App">
      <header className="app-header">
        <h1>YouTube Suggestions</h1>
        <p>Discover amazing content recommendations</p>
      </header>
      
      <main className="suggestions-container">
        <div className="suggestions-grid">
          {suggestions.map((suggestion) => (
            <div key={suggestion.id} className="suggestion-card">
              <div className="thumbnail-container">
                <img 
                  src={suggestion.thumbnail} 
                  alt={suggestion.title}
                  className="thumbnail"
                />
                <div className="play-overlay">
                  <span className="play-icon">▶</span>
                </div>
              </div>
              <div className="video-info">
                <h3 className="video-title">{suggestion.title}</h3>
                <p className="channel-name">{suggestion.channel}</p>
                <p className="view-count">{suggestion.views} views</p>
              </div>
            </div>
          ))}
        </div>
      </main>
    </div>
  );
}

export default App;

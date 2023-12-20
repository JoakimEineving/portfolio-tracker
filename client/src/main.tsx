import ReactDOM from 'react-dom/client';
import { StrictMode } from 'react';
import App from "./App.tsx";
import "./index.css";

const root = ReactDOM.createRoot(document.getElementById('root')!);

root.render(
  <StrictMode>
      <App />
  </StrictMode>
);

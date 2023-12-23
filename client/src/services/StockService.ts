import axios from 'axios';

export class StockService {
    private static backendUrl = import.meta.env.VITE_BACKEND_URL;
  
    static async getStocks() {
        try {
          const response = await axios.get(`${this.backendUrl}/Stock`);
          return response.data;
        } catch (error) {
          console.error('Failed to fetch stocks:', error);
          throw error;
        }
      }
    }
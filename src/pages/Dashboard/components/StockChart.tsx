import { useEffect, useRef } from "react";
import Chart, { ChartConfiguration } from "chart.js/auto";
import { Stock, StockHistory } from "../../../types/Stock";

interface StockChartProps {
  stockData: Stock;
  stockHistory: StockHistory[];
}

const StockChart: React.FC<StockChartProps> = ({ stockData, stockHistory }) => {
  const chartRef = useRef<HTMLCanvasElement>(null);
  const chartInstance = useRef<Chart | null>(null);

  useEffect(() => {
    if (chartRef && chartRef.current) {
      const ctx = chartRef.current.getContext("2d");
      if (ctx) {
        if (chartInstance.current) {
          chartInstance.current.destroy();
        }
        //reversing stock history, so that the chart starts from the beginning
        const reversedStockHistory = [...stockHistory].reverse();

        const chartConfig: ChartConfiguration = {
          type: "line",
          data: {
            labels: reversedStockHistory.map((data) => data.date),
            datasets: [
              {
                label: `${stockData.symbol} Stock Price`,
                data: reversedStockHistory.map((data) => data.close),
                fill: false,
                borderColor: "rgb(75, 192, 192)",
                tension: 0.1,
              },
            ],
          },
          options: {
            scales: {
              y: {
                beginAtZero: true,
              },
            },
          },
        };

        chartInstance.current = new Chart(ctx, chartConfig);
      }
    }

    return () => {
      if (chartInstance.current) {
        chartInstance.current?.destroy();
      }
    };
  }, [stockHistory, stockData.symbol]);

  return <canvas ref={chartRef} />;
};

export default StockChart;
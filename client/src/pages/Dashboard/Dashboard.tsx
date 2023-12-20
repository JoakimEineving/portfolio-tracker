import { useState } from "react";
import { Header } from "../../components";
import Card from "./components/Card";
// import Search from "./components/Search";
import Stat from "./components/Stat";
import { mockStockHistory, mockStocks } from "../../constants/mock";
import { Stock, StockHistory } from "../../types/Stock";
import StockChart from "./components/StockChart";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faCaretDown, faCaretUp, faCalendarDays } from "@fortawesome/free-solid-svg-icons";

function Dashboard() {
  const [selectedStock, setSelectedStock] = useState<Stock>(mockStocks[0]);
  const [selectedStockHistory, setSelectedStockHistory] = useState<
    StockHistory[]
  >(mockStockHistory[0].historical);
  const [timeRange, setTimeRange] = useState<number>(180);

  const handleTimeRangeChange = (range: number) => {
    setTimeRange(range);
  };
  const endDate = new Date();
  const startDate = new Date();
  startDate.setDate(endDate.getDate() - timeRange);
  const filteredHistory = selectedStockHistory.filter(
    (data) => new Date(data.date) >= startDate
  );

  const handleStockSelect = (stock: Stock) => {
    setSelectedStock(stock);

    const stockHistory = mockStockHistory.find(
      (history) => history.symbol === stock.symbol
    );
    if (stockHistory) {
      setSelectedStockHistory(stockHistory.historical);
    }
  };

  return (
    <>
      <Header />
      {/* <Search /> */}
      <div className="h-screen grid grid-cols-1 md:grid-cols-2 xl:grid-cols-3 grid-rows-8 md:grid-rows-7 xl:grid-rows-5 auto-rows-fr gap-6 p-10">
        <div className="col-span-3 row-span-1 flex justify-start items-center ">
          <Card title=""><Stat title="Portfolio Value" value="$1,000,000" description="Total value of your portfolio" />
          <Stat title="Portfolio Value" value="$1,000,000" description="Total value of your portfolio" />
          <Stat title="Portfolio Value" value="$1,000,000" description="Total value of your portfolio" />
          <Stat title="Portfolio Value" value="$1,000,000" description="Total value of your portfolio" />
          </Card>
        </div>
        <div className="md:col-span-2 row-span-4">
          <Card title="">
            <div className="dropdown">
              <div tabIndex={0} role="button" className="btn btn-neutral">
                <FontAwesomeIcon icon={faCalendarDays} />{timeRange} Days
              </div>
              <ul
                tabIndex={0}
                className="dropdown-content z-[1] menu p-2 shadow bg-base-100 rounded-box w-52"
              >
                <li>
                  <a onClick={() => handleTimeRangeChange(7)}>7 Days</a>
                </li>
                <li>
                  <a onClick={() => handleTimeRangeChange(30)}>1 Month</a>
                </li>
                <li>
                  <a onClick={() => handleTimeRangeChange(90)}>3 Months</a>
                </li>
                <li>
                  <a onClick={() => handleTimeRangeChange(180)}>6 Months</a>
                </li>
              </ul>
            </div>
            <StockChart
              stockData={selectedStock || "Portfolio"}
              stockHistory={filteredHistory}
            />
          </Card>
        </div>
        <div className="row-span-2 xl:row-span-4 overflow-auto ">
          <Card title="Your assets">
            <table className="table table-zebra">
              <thead>
                <tr>
                  <th>Ticker</th>
                  <th>Price</th>
                  <th>High</th>
                  <th>Low</th>
                  <th>Change</th>
                </tr>
              </thead>
              <tbody>
                {mockStocks.map((stock, index) => (
                  <tr
                    key={index}
                    onClick={() => handleStockSelect(stock)}
                    className={
                      selectedStock.symbol === stock.symbol
                        ? "border-2 border-primary"
                        : ""
                    }
                  >
                    <td
                      className={
                        stock.changesPercentage > 0
                          ? "text-success"
                          : "text-error"
                      }
                    >
                      {stock.changesPercentage > 0 ? (
                        <FontAwesomeIcon icon={faCaretUp} />
                      ) : (
                        <FontAwesomeIcon icon={faCaretDown} />
                      )}
                      {stock.symbol}
                    </td>
                    <td>${stock.price.toFixed(2)}</td>
                    <td>${stock.dayHigh.toFixed(2)}</td>
                    <td>${stock.dayLow.toFixed(2)}</td>
                    <td className={stock.changesPercentage > 0 ? "text-success"
                          : "text-error"
                      }>{stock.changesPercentage.toFixed(2)}%</td>
                  </tr>
                ))}
              </tbody>
            </table>
          </Card>
        </div>
      </div>
    </>
  );
}

export default Dashboard;

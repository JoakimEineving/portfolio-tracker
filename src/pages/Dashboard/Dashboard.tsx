import { Header } from "../../components";
import Card from "./components/Card";
import Search from "./components/Search";
import { mockStocks } from "../../constants/mock";

function Dashboard() {
  return (
    <>
      <Header />
      <Search />
      <div className="h-screen grid grid-cols-1 md:grid-cols-2 xl:grid-cols-3 grid-rows-8 md:grid-rows-7 xl:grid-rows-5 auto-rows-fr gap-6 p-10">
        <div className="col-span-1 md:col-span-2 xl:col-span-3 row-span-1 flex justify-start items-center">
          <Card title="Overview"> </Card>
        </div>
        <div className="md:col-span-2 row-span-4">
          <Card title="Chart"> </Card>
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
                </tr>
              </thead>
              <tbody>
                {mockStocks.map((stock, index) => (
                  <tr key={index}>
                    <td>{stock.symbol}</td>
                    <td>${parseFloat(stock.price).toFixed(2)}</td>
                    <td>${parseFloat(stock.high).toFixed(2)}</td>
                    <td>${parseFloat(stock.low).toFixed(2)}</td>
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

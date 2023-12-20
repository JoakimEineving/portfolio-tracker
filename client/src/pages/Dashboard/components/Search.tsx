import { useState } from "react";
import { mockStocks } from "../../../constants/mock";
import { Stock } from "../../../types/Stock";

const Search = () => {
  const [search, setSearch] = useState("");
  const [searchResults, setSearchResults] = useState<Stock[]>([]);

  const handleInputChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    const searchText = event.target.value;
    setSearch(searchText);

    if (searchText !== "") {
      const filteredResults = mockStocks.filter((stock) =>
        stock.symbol.toLowerCase().includes(searchText.toLowerCase())
      );
      setSearchResults(filteredResults);
      
    } else {
      setSearchResults([]);
    }
  };

  return (
    <div className="search-container">
      <input
        type="text"
        placeholder="Search stocks..."
        value={search}
        onChange={handleInputChange}
      />
      {searchResults.length > 0 && (
        <div className="search-results">
          <ul>
            {searchResults.map((stock, index) => (
              <li key={index}>{stock.symbol}</li>
            ))}
          </ul>
        </div>
      )}
    </div>
  );
};

export default Search;

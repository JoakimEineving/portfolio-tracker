import { Link } from "react-router-dom";

function Hero({title, description}: {title: string, description: string}) {
  return (
    <div className="hero min-h-screen">
      <div className="hero-content flex-col lg:flex-row-reverse">
        {/* <img src={} className="max-w-sm rounded-lg" /> */}
        <div>
          <h1 className="text-5xl font-bold">{title}</h1>
          <p className="py-6">
            {description}
          </p><Link to="/dashboard"><button className="btn btn-primary">Go to dashboard</button></Link>
        </div>
      </div>
    </div>
  );
}

export default Hero;

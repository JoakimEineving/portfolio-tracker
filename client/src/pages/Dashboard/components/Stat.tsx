interface StatProps {
  title: string;
  value: string | number;
  description: string;
}

const Stat: React.FC<StatProps> = ({ title, value, description }) => {
  return (
    <div className="stat w-20 md:w-36 lg:w-60">
      <div className="stat-title">{title}</div>
      <div className="stat-value">{value}</div>
      <div className="stat-desc">{description}</div>
    </div>
  );
};

export default Stat;
import React from "react";

interface CardProps extends React.PropsWithChildren {
  title: string;
  children: React.ReactNode;
}

const Card: React.FC<CardProps> = ({ title, children }) => {
  return (
    <div className="w-full h-full rounded-md relative p-8 border-2 border-neutral">
      <h2>{title}</h2>
      {children}
    </div>
  );
};

export default Card;

'use client'
import { useEffect, useState } from 'react';
import { product } from '@/type/product';
export default function Home() {

  const [products, setProducts] = useState<product[]>([])

  const getProduct = async () => {
    const res = await fetch("https://localhost:7170/Products");
    const json = await res.json();

    setProducts(json)
  }
  useEffect(() => {
    getProduct()
  }, [])

  return (



    <div >
      {products.map(item=>(
        <ul key={item.productId}>
          <li>{item.name}</li>
        </ul>
      ))}
    </div>
  );
}

import { useEffect, useState } from "react";
import { Customer } from "../types/customer";

const API_URL = "http://localhost:5200/api";

export function useCustomers() {
  const [customers, setCustomers] = useState<Customer[]>([]);
  const [custLoading, setLoading] = useState(true);
  const [custError, setError] = useState<string | null>(null);

  useEffect(() => {
    const fetchCustomers = async () => {
      setLoading(true);
      setError(null);

      try {
        const response = await fetch(`${API_URL}/Fines/GetCustomers`);

        if (!response.ok) {
          throw new Error(response.statusText);
        }

        const raw = await response.json();
        const customers = raw.map((customer: any) => ({
          ...customer,
        }));

        setCustomers(customers);
      } catch (err) {
        console.error(err);
        setError("Failed to fetch customers");
      } finally {
        setLoading(false);
      }
    };

    fetchCustomers();
  }, []);

  return { customers, custLoading, custError };
}

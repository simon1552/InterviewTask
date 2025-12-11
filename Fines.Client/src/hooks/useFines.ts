import { useEffect, useState } from "react";
import { Fine } from "../types/fine";

const API_URL = "http://localhost:5200/api";

interface UseFinesParams {
  fineType?: string;
  fineDate?: string;
  vehicleReg?: string;
}

export function useFines(params: UseFinesParams = {}) {
  const [fines, setFines] = useState<Fine[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    const fetchFines = async () => {
      setLoading(true);
      setError(null);

      try {
        const query = new URLSearchParams();
        if (params.fineType) query.append("fineType", params.fineType);
        if (params.fineDate) query.append("fineDate", params.fineDate);
        if (params.vehicleReg) query.append("vehicleReg", params.vehicleReg);

        const response = await fetch(`${API_URL}/fines/getFilteredFines?${query.toString()}`);

        if (!response.ok) {
          throw new Error(response.statusText);
        }

        const raw = await response.json();
        const fines = raw.map((fine: any) => ({
          ...fine,
          fineDate: new Date(fine.fineDate),
        }));

        setFines(fines);
      } catch (err) {
        console.error(err);
        setError("Failed to fetch fines");
      } finally {
        setLoading(false);
      }
    };

    fetchFines();
  }, [params.fineType, params.fineDate, params.vehicleReg]);

  return { fines, loading, error };
}

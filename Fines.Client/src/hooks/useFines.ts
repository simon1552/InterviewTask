import { useEffect, useState } from "react";
import { FineType } from "../enum/fineType";

const API_URL = "https://localhost:7200/api";

interface Fine {
    fineRef: string;
    fineDate: Date;
    fineType: FineType;
    customerName: string;
    vehicleReg: string;
    driverName: string;
}

export function useFines() {
    const [fines, setFines] = useState<Fine[]>([]);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState<string | null>(null);

    useEffect(() => {
        const fetchFines = async () => {
            setLoading(true);
            setError(null);

            try {
                const response = await fetch(`${API_URL}/fines`);
                if (!response.ok) {
                    throw new Error(response.statusText);
                }
                const raw = await response.json();
                const fines = raw.map((fine: any) => ({
                    ...fine,
                    fineDate: new Date(fine.fineDate)
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
    }, []);

    return { fines, loading, error };
}
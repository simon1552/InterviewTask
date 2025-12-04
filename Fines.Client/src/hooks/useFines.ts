import { useEffect, useState } from "react";

interface Fine {
    fineRef: string;
    fineDate: string;
    fineType: string;
    customerName: string;
    vehicleReg: string;
    driverName: string;
}

const DUMMY_FINES: Fine[] = [
    {
        fineRef: "F12345",
        fineDate: "2024-01-15",
        fineType: "Speeding",
        customerName: "John Doe",
        vehicleReg: "ABC123",
        driverName: "Jane Smith"
    },
    {
        fineRef: "F67890",
        fineDate: "2024-02-20",
        fineType: "Illegal Parking",
        customerName: "Alice Johnson",
        vehicleReg: "XYZ789",
        driverName: "Bob Brown"
    }
];

export function useFines() {
    const [fines, setFines] = useState<Fine[]>([]);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState<string | null>(null);

    useEffect(() => {
        const fetchFines = async () => {
            setLoading(true);
            setError(null);

            try {
                await new Promise(resolve => setTimeout(resolve, 800));
                setFines(DUMMY_FINES);
            } catch (err) {
                setError("Failed to fetch fines");
            } finally {
                setLoading(false);
            }
        };

        fetchFines();
    }, []);

    return { fines, loading, error };
}
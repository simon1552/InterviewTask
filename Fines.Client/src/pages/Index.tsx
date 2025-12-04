import { Button, Collapse, Loader, Paper, Table, Text } from "@mantine/core";
import { useDisclosure } from "@mantine/hooks";
import { useFines } from "../hooks/useFines";

export default function Index() {
    const [opened, { toggle }] = useDisclosure(false);
    const { fines, loading, error } = useFines();

    const rows = fines.map((fine) => (
        <Table.Tr key={fine.fineRef}>
            <Table.Td>{fine.fineRef}</Table.Td>
            <Table.Td>{fine.fineDate}</Table.Td>
            <Table.Td>{fine.fineType}</Table.Td>
            <Table.Td>{fine.customerName}</Table.Td>
            <Table.Td>{fine.vehicleReg}</Table.Td>
            <Table.Td>{fine.driverName}</Table.Td>
        </Table.Tr>
    ));

    return (
        <main>
            <h2>Index</h2>

            <Button onClick={toggle} mb="md">Filters</Button>
            <Collapse in={opened}>
                <Paper shadow="xs" px="xl" py="md" mb="md">
                    Filters will go here.
                </Paper>
            </Collapse>

            <Paper shadow="xs" p="xl">
                {loading ? (
                    <Loader />
                ) : error ? (
                    <Text c="red">{error}</Text>
                ) : (
                    <Table>
                        <Table.Thead>
                            <Table.Tr>
                                <Table.Th>Reference</Table.Th>
                                <Table.Th>Date</Table.Th>
                                <Table.Th>Type</Table.Th>
                                <Table.Th>Customer</Table.Th>
                                <Table.Th>Registration</Table.Th>
                                <Table.Th>Driver</Table.Th>
                            </Table.Tr>
                        </Table.Thead>
                        <Table.Tbody>{rows}</Table.Tbody>
                    </Table>
                )}
            </Paper>
        </main>);
}


export class PaginationService {
    getPager(totalItems: number, currentPage: number = 1, pageSize: number = 5, totalPages: number) {
        const offset = 2;
        let startPage: number, endPage: number;
        if (totalPages <= 5) {
            startPage = 1;
            endPage = totalPages;
        } else {
            if (currentPage <= 3) {
                startPage = 1;
                endPage = 5;
            } else if (currentPage + 1 >= totalPages) {
                startPage = totalPages - 4;
                endPage = totalPages;
            } else {
                startPage = currentPage - offset;
                endPage = currentPage + offset;
            }
        }
        const startIndex = (currentPage - 1) * pageSize;
        const endIndex = Math.min(startIndex + pageSize - 1, totalItems - 1);
        const pages: number[] = [];
        for (let i = startPage; i <= endPage; i++) {
           pages.push(i);
        }
        return {
            totalItems: totalItems,
            currentPage: currentPage,
            pageSize: pageSize,
            totalPages: totalPages,
            startPage: startPage,
            endPage: endPage,
            startIndex: startIndex,
            endIndex: endIndex,
            pages: pages
        };
    }
}

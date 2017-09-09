// import { User } from '../../profile/models/user.model';
import { User } from '../../profile/models/user.model';

export class Team {
  Id: number;
  Name: string;
  CreatedOn: Date;
  DepartmentId: number;
  Employees: User[];
}
